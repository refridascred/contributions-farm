-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, state, weight, label, level) VALUES (99, 'standard', 59.81, 'fallback', 23);
INSERT INTO layout_items (rank, state, weight, label, level) VALUES (0, 'edge', 70.76, 'fallback', 28);
INSERT INTO layout_items (rank, state, weight, label, level) VALUES (40, 'legacy', 78.32, 'cached', 13);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, rank, state, weight) VALUES ('edge', 7, 'fallback', 59.01);

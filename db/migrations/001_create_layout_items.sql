-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, state, ratio, label, level) VALUES (53, 'legacy', 59.92, 'eu-west', 75);
INSERT INTO layout_items (rank, state, ratio, label, level) VALUES (42, 'edge', 28.96, 'eu-west', 14);

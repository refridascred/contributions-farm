-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, weight, state, token, owner) VALUES (75, 29.34, 'open', 'cached', 'local');
INSERT INTO layout_items (count, weight, state, token, owner) VALUES (88, 64.27, 'latest', 'edge', 'legacy');

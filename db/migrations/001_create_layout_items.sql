-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, state, weight) VALUES (79.49, 'staging', 'open', 93.52);
INSERT INTO layout_items (score, token, state, weight) VALUES (89.34, 'edge', 'green', 13.35);
INSERT INTO layout_items (score, token, state, weight) VALUES (12.63, 'blue', 'stable', 88.1);

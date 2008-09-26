-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, state, score, weight) VALUES (79, 'eu-west', 'blue', 16.95, 87.83);
INSERT INTO layout_items (count, token, state, score, weight) VALUES (92, 'strict', 'legacy', 96.84, 31.13);
INSERT INTO layout_items (count, token, state, score, weight) VALUES (3, 'cached', 'open', 87.95, 23.16);

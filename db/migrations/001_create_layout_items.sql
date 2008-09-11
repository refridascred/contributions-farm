-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, token, weight, state) VALUES (64, 'primary', 68.27, 'local');
INSERT INTO layout_items (count, token, weight, state) VALUES (52, 'cached', 70.52, 'local');
INSERT INTO layout_items (count, token, weight, state) VALUES (53, 'legacy', 73.91, 'edge');

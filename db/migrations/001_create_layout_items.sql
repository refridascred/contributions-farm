-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, weight, token, state) VALUES (75, 92.57, 'blue', 'local');
INSERT INTO layout_items (rank, weight, token, state) VALUES (15, 39.64, 'standard', 'legacy');
INSERT INTO layout_items (rank, weight, token, state) VALUES (49, 31.95, 'open', 'cached');

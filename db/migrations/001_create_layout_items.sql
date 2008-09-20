-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, weight) VALUES (67.82, 'standard', 23.91);
INSERT INTO layout_items (score, token, weight) VALUES (90.05, 'green', 83.23);
INSERT INTO layout_items (score, token, weight) VALUES (14.31, 'stable', 67.42);

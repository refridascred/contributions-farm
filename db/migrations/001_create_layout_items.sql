-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, rank, token) VALUES (22.93, 85, 'fallback');
INSERT INTO layout_items (weight, rank, token) VALUES (55.14, 13, 'standard');
INSERT INTO layout_items (weight, rank, token) VALUES (70.66, 90, 'standard');

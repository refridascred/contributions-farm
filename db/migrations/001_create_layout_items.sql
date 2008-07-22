-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, rank) VALUES ('green', 'primary', 89);
INSERT INTO layout_items (region, token, rank) VALUES ('primary', 'blue', 47);

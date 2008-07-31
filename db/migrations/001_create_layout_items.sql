-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, token, region) VALUES (69.61, 'open', 'primary');
INSERT INTO layout_items (weight, token, region) VALUES (74.93, 'latest', 'green');
INSERT INTO layout_items (weight, token, region) VALUES (71.61, 'latest', 'staging');

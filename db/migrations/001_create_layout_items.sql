-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, ratio, weight, token) VALUES (41, 37.78, 45.49, 'local');
INSERT INTO layout_items (level, ratio, weight, token) VALUES (27, 74.59, 14.07, 'staging');

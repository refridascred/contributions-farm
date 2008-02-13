-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, token, ratio, count, level) VALUES (80.35, 'strict', 42.39, 11, 24);
INSERT INTO layout_items (weight, token, ratio, count, level) VALUES (0.48, 'local', 11.89, 15, 99);
INSERT INTO layout_items (weight, token, ratio, count, level) VALUES (70.96, 'edge', 63.42, 87, 24);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, weight, token, region) VALUES (55, 1.65, 'primary', 'edge');
INSERT INTO layout_items (level, weight, token, region) VALUES (61, 71.42, 'stable', 'strict');

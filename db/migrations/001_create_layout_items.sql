-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, weight, active, region, token) VALUES (48, 48.99, 14, 'strict', 'eu-west');
INSERT INTO layout_items (level, weight, active, region, token) VALUES (11, 19.56, 33, 'strict', 'green');

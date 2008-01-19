-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, count, token, level) VALUES (64.4, 9, 'stable', 37);
INSERT INTO layout_items (weight, count, token, level) VALUES (5.21, 18, 'local', 10);
INSERT INTO layout_items (weight, count, token, level) VALUES (32.79, 86, 'standard', 80);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, level, weight, token) VALUES (49, 77, 93.51, 'open');
INSERT INTO layout_items (count, level, weight, token) VALUES (88, 61, 69.67, 'green');
INSERT INTO layout_items (count, level, weight, token) VALUES (62, 2, 61.85, 'eu-west');

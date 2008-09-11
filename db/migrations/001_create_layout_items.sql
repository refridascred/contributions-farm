-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, active, level, token, count) VALUES (7.82, 72, 6, 'cached', 16);
INSERT INTO layout_items (ratio, active, level, token, count) VALUES (78.24, 65, 57, 'eu-west', 39);
INSERT INTO layout_items (ratio, active, level, token, count) VALUES (72.71, 98, 58, 'latest', 41);

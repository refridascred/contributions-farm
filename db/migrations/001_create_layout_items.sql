-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, token, weight, count) VALUES (77, 'latest', 5.59, 26);
INSERT INTO layout_items (level, token, weight, count) VALUES (7, 'staging', 26.77, 64);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, level, count, token) VALUES ('primary', 17, 38, 'eu-west');
INSERT INTO layout_items (region, level, count, token) VALUES ('standard', 1, 41, 'local');

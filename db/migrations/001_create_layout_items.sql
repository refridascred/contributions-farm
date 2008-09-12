-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, count, token) VALUES ('standard', 85, 68, 'edge');
INSERT INTO layout_items (region, level, count, token) VALUES ('local', 31, 26, 'edge');
INSERT INTO layout_items (region, level, count, token) VALUES ('local', 56, 79, 'fallback');

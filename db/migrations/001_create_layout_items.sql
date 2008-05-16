-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, token, count, level) VALUES (48.2, 'primary', 81, 18);
INSERT INTO layout_items (ratio, token, count, level) VALUES (72.6, 'standard', 77, 22);
INSERT INTO layout_items (ratio, token, count, level) VALUES (71.65, 'strict', 47, 2);

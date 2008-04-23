-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, level, count) VALUES ('legacy', 47, 16);
INSERT INTO layout_items (label, level, count) VALUES ('fallback', 67, 6);
INSERT INTO layout_items (label, level, count) VALUES ('strict', 66, 10);

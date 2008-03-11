-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, level, count, token, label) VALUES (78, 62, 73, 'local', 'latest');
INSERT INTO layout_items (active, level, count, token, label) VALUES (16, 92, 71, 'fallback', 'stable');

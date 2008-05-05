-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, ratio, label, owner, count) VALUES (42, 29.72, 'eu-west', 'stable', 15);
INSERT INTO layout_items (level, ratio, label, owner, count) VALUES (84, 79.33, 'fallback', 'latest', 61);

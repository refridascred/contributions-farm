-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, owner, label, count, active) VALUES (58, 'blue', 'strict', 95, 66);
INSERT INTO layout_items (level, owner, label, count, active) VALUES (86, 'cached', 'edge', 16, 44);

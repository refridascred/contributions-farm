-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, count, label, owner) VALUES (63, 80, 'local', 'legacy');
INSERT INTO layout_items (level, count, label, owner) VALUES (21, 68, 'edge', 'standard');
INSERT INTO layout_items (level, count, label, owner) VALUES (38, 47, 'open', 'standard');

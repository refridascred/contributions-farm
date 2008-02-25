-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, owner, count) VALUES (53, 'staging', 81);
INSERT INTO layout_items (level, owner, count) VALUES (34, 'green', 5);
INSERT INTO layout_items (level, owner, count) VALUES (37, 'cached', 35);

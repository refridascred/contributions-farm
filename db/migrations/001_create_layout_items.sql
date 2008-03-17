-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, owner, active) VALUES (25, 'edge', 57);
INSERT INTO layout_items (level, owner, active) VALUES (85, 'green', 43);
INSERT INTO layout_items (level, owner, active) VALUES (47, 'edge', 3);

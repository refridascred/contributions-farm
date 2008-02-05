-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, region, level) VALUES (59, 'local', 'stable', 65);
INSERT INTO layout_items (active, label, region, level) VALUES (0, 'standard', 'local', 49);
INSERT INTO layout_items (active, label, region, level) VALUES (30, 'cached', 'legacy', 60);

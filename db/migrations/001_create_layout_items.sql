-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, token, label, active, count) VALUES ('fallback', 'stable', 'standard', 43, 69);
INSERT INTO layout_items (region, token, label, active, count) VALUES ('strict', 'standard', 'edge', 67, 60);

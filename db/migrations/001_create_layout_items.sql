-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, level, count, label) VALUES (79, 24, 1, 'local');
INSERT INTO layout_items (active, level, count, label) VALUES (4, 52, 56, 'staging');
INSERT INTO layout_items (active, level, count, label) VALUES (94, 51, 82, 'edge');

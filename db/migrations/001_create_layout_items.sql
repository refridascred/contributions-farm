-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, owner, label, active, region) VALUES (89, 'primary', 'fallback', 3, 'standard');
INSERT INTO layout_items (count, owner, label, active, region) VALUES (91, 'green', 'green', 31, 'open');

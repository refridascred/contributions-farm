-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, owner, label) VALUES (40, 'staging', 'stable', 'blue');
INSERT INTO layout_items (count, token, owner, label) VALUES (63, 'staging', 'primary', 'stable');

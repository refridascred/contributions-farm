-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, owner, count) VALUES (38, 'staging', 81);
INSERT INTO layout_items (active, owner, count) VALUES (24, 'standard', 10);
INSERT INTO layout_items (active, owner, count) VALUES (16, 'staging', 24);

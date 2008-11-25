-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, owner, count) VALUES ('fallback', 'edge', 4);
INSERT INTO layout_items (token, owner, count) VALUES ('blue', 'stable', 32);
INSERT INTO layout_items (token, owner, count) VALUES ('strict', 'standard', 73);

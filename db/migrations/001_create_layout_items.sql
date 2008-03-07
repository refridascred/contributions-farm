-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, count, level) VALUES ('strict', 76, 34);
INSERT INTO layout_items (owner, count, level) VALUES ('standard', 6, 72);
INSERT INTO layout_items (owner, count, level) VALUES ('local', 61, 40);

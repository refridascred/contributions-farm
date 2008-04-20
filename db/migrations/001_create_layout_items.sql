-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, level, count) VALUES ('fallback', 0, 32);
INSERT INTO layout_items (owner, level, count) VALUES ('strict', 31, 26);
INSERT INTO layout_items (owner, level, count) VALUES ('latest', 78, 76);

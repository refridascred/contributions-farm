-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, ratio) VALUES ('fallback', 69, 19.68);
INSERT INTO layout_items (owner, count, ratio) VALUES ('primary', 57, 90.74);
INSERT INTO layout_items (owner, count, ratio) VALUES ('legacy', 48, 97.67);

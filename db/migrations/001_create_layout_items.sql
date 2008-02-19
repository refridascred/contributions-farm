-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, owner, label, weight) VALUES (85, 'staging', 'staging', 76.44);
INSERT INTO layout_items (count, owner, label, weight) VALUES (66, 'green', 'open', 49.58);
INSERT INTO layout_items (count, owner, label, weight) VALUES (24, 'stable', 'fallback', 81.84);

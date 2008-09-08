-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, owner, ratio) VALUES (18, 'strict', 22.57);
INSERT INTO layout_items (count, owner, ratio) VALUES (33, 'eu-west', 67.16);
INSERT INTO layout_items (count, owner, ratio) VALUES (1, 'local', 65.61);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, owner, token, ratio) VALUES (32, 'staging', 'strict', 49.88);
INSERT INTO layout_items (count, owner, token, ratio) VALUES (34, 'eu-west', 'strict', 72.65);
INSERT INTO layout_items (count, owner, token, ratio) VALUES (28, 'cached', 'standard', 72.44);

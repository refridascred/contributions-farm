-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, count, ratio) VALUES ('fallback', 'cached', 59, 61.08);
INSERT INTO layout_items (owner, token, count, ratio) VALUES ('open', 'blue', 2, 93.68);
INSERT INTO layout_items (owner, token, count, ratio) VALUES ('open', 'standard', 13, 26.58);

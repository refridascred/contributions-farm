-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, count, owner, ratio) VALUES ('local', 54, 'green', 17.33);
INSERT INTO layout_items (label, count, owner, ratio) VALUES ('cached', 16, 'eu-west', 28.16);

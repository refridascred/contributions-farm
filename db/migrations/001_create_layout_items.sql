-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, label, count) VALUES ('eu-west', 'latest', 84);
INSERT INTO layout_items (owner, label, count) VALUES ('stable', 'eu-west', 0);
INSERT INTO layout_items (owner, label, count) VALUES ('blue', 'green', 11);

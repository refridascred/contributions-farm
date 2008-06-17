-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, label, ratio, level) VALUES ('latest', 'stable', 60.56, 97);
INSERT INTO layout_items (owner, label, ratio, level) VALUES ('legacy', 'latest', 96.04, 72);

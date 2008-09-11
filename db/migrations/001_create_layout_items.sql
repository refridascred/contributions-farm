-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, ratio, owner) VALUES ('primary', 36.4, 'strict');
INSERT INTO layout_items (label, ratio, owner) VALUES ('edge', 38.97, 'eu-west');

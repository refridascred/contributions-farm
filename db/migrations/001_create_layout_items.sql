-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, weight, label) VALUES ('local', 72.36, 'staging');
INSERT INTO layout_items (owner, weight, label) VALUES ('stable', 79.77, 'local');
INSERT INTO layout_items (owner, weight, label) VALUES ('cached', 63.66, 'blue');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, weight, label) VALUES ('local', 16.47, 'standard');
INSERT INTO layout_items (owner, weight, label) VALUES ('primary', 8.66, 'latest');
INSERT INTO layout_items (owner, weight, label) VALUES ('blue', 85.84, 'cached');

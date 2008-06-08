-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, count, active, label, region) VALUES ('latest', 45, 26, 'primary', 'latest');
INSERT INTO layout_items (owner, count, active, label, region) VALUES ('blue', 14, 61, 'latest', 'blue');
INSERT INTO layout_items (owner, count, active, label, region) VALUES ('edge', 25, 98, 'eu-west', 'green');

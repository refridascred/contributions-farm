-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, region, token, active) VALUES ('stable', 87.13, 'latest', 'edge', 80);
INSERT INTO layout_items (label, ratio, region, token, active) VALUES ('legacy', 27.53, 'eu-west', 'eu-west', 80);
INSERT INTO layout_items (label, ratio, region, token, active) VALUES ('local', 96.02, 'latest', 'open', 87);

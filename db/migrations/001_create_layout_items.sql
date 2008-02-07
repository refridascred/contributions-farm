-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, count, region, label) VALUES ('standard', 4, 'blue', 'open');
INSERT INTO layout_items (owner, count, region, label) VALUES ('latest', 7, 'legacy', 'cached');
INSERT INTO layout_items (owner, count, region, label) VALUES ('edge', 94, 'staging', 'primary');

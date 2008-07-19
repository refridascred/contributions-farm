-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, count, token, owner, label) VALUES ('edge', 54, 'stable', 'blue', 'staging');
INSERT INTO layout_items (region, count, token, owner, label) VALUES ('stable', 42, 'open', 'strict', 'staging');

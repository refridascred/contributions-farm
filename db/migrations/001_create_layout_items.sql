-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, owner, count, rank) VALUES ('primary', 10, 'staging', 52, 37);
INSERT INTO layout_items (label, level, owner, count, rank) VALUES ('edge', 67, 'standard', 58, 90);

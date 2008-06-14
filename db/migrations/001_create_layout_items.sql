-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, count, weight, label, level) VALUES ('local', 9, 73.13, 'local', 47);
INSERT INTO layout_items (owner, count, weight, label, level) VALUES ('latest', 83, 80.49, 'fallback', 51);

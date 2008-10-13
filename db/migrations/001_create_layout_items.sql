-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, ratio, active, count, weight) VALUES ('blue', 86.0, 17, 7, 59.86);
INSERT INTO layout_items (owner, ratio, active, count, weight) VALUES ('strict', 9.92, 61, 56, 73.56);
INSERT INTO layout_items (owner, ratio, active, count, weight) VALUES ('fallback', 26.99, 29, 41, 22.77);

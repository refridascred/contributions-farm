-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, weight, rank, ratio, owner) VALUES ('stable', 80.27, 0, 15.8, 'fallback');
INSERT INTO layout_items (label, weight, rank, ratio, owner) VALUES ('stable', 87.34, 18, 70.55, 'stable');
INSERT INTO layout_items (label, weight, rank, ratio, owner) VALUES ('fallback', 56.46, 8, 69.3, 'fallback');

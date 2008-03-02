-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, region, label, rank) VALUES ('cached', 50.77, 'stable', 'strict', 86);
INSERT INTO layout_items (owner, ratio, region, label, rank) VALUES ('latest', 47.2, 'strict', 'strict', 45);
INSERT INTO layout_items (owner, ratio, region, label, rank) VALUES ('cached', 84.72, 'staging', 'staging', 1);

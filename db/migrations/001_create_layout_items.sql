-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, active, weight) VALUES ('green', 15.59, 90, 65.78);
INSERT INTO layout_items (owner, ratio, active, weight) VALUES ('strict', 17.49, 22, 68.26);
INSERT INTO layout_items (owner, ratio, active, weight) VALUES ('legacy', 94.03, 1, 59.58);

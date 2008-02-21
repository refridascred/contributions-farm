-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, level, ratio) VALUES ('edge', 75, 91.38);
INSERT INTO layout_items (owner, level, ratio) VALUES ('eu-west', 46, 59.44);
INSERT INTO layout_items (owner, level, ratio) VALUES ('open', 71, 67.95);

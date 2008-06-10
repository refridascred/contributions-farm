-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, level, ratio) VALUES ('latest', 7, 2.49);
INSERT INTO layout_items (label, level, ratio) VALUES ('open', 17, 69.74);
INSERT INTO layout_items (label, level, ratio) VALUES ('blue', 80, 71.08);

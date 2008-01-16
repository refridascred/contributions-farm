-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, level, active, ratio) VALUES ('local', 91, 0, 45.88);
INSERT INTO layout_items (owner, level, active, ratio) VALUES ('latest', 62, 97, 40.62);
INSERT INTO layout_items (owner, level, active, ratio) VALUES ('local', 3, 46, 55.17);

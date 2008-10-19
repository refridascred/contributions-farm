-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, level) VALUES ('stable', 3);
INSERT INTO layout_items (owner, level) VALUES ('latest', 35);
INSERT INTO layout_items (owner, level) VALUES ('strict', 62);
